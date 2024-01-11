using Skills.Properties;
using System.Text.Json;

namespace Skills
{
    public partial class MainForm : Form
    {
        public List<Skill> Skills = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Load the saved skills
                foreach (string? s in Settings.Default.Skills)
                {
                    if (s != null)
                    {
                        Skill? skill = JsonSerializer.Deserialize<Skill>(s);
                        if (skill != null)
                        {
                            Skills.Add(skill);
                        }
                    }
                }

                // Display the number of skills loaded
                if (Skills.Count > 0)
                {
                    StatusTextBox.AppendText("Loaded " + Skills.Count.ToString() + (Skills.Count > 1 ? " skills" : " skill"));
                }
                else
                {
                    // If skills list is empty, load some sample skills
                    AddSampleSkills();
                    StatusTextBox.AppendText("Loading sample skills.");
                }

                // Update the skills listbox
                UpdateSkillsListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSampleSkills()
        {
            // Demo data
            Skills.Add(new Skill() { Name = "Alchemy" });
            Skills.Add(new Skill() { Name = "Archaeology" });
            Skills.Add(new Skill() { Name = "Archery" });
            Skills.Add(new Skill() { Name = "Basketball" });
            Skills.Add(new Skill() { Name = "Camping" });
            Skills.Add(new Skill() { Name = "Carpentry" });
            Skills.Add(new Skill() { Name = "Cartography" });
            Skills.Add(new Skill() { Name = "Cleaning" });
            Skills.Add(new Skill() { Name = "Cooking" });
            Skills.Add(new Skill() { Name = "Fishing" });
            Skills.Add(new Skill() { Name = "Fitness" });
            Skills.Add(new Skill() { Name = "Gardening" });
            Skills.Add(new Skill() { Name = "Guitar" });
            Skills.Add(new Skill() { Name = "Logic" });
            Skills.Add(new Skill() { Name = "Meditation" });
            Skills.Add(new Skill() { Name = "Painting" });
            Skills.Add(new Skill() { Name = "Programming" });
            Skills.Add(new Skill() { Name = "Scuba diving" });
            Skills.Add(new Skill() { Name = "Snowboarding" });
            Skills.Add(new Skill() { Name = "Writing" });
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Sort based on which radio button is checked
                if (sender is RadioButton radioButton && radioButton.Checked == true)
                {
                    switch (radioButton.Name)
                    {
                        case nameof(AlphabeticalRadioButton):
                            // Sort alphabetically
                            Skills.Sort(delegate (Skill x, Skill y)
                            {
                                return x.Name.CompareTo(y.Name);
                            });
                            break;

                        case nameof(LevelRadioButton):
                            // Sort by level first, alphabetically second
                            Skills.Sort(delegate (Skill x, Skill y)
                            {
                                if (x.Level == y.Level) return x.Name.CompareTo(y.Name);
                                else return y.Level.CompareTo(x.Level);
                            });
                            break;

                        case nameof(LastUsedRadioButton):
                            // Sort by last used first, alphabetically second
                            Skills.Sort(delegate (Skill x, Skill y)
                            {
                                if (x.LastUsed == y.LastUsed) return x.Name.CompareTo(y.Name);
                                else return y.LastUsed.CompareTo(x.LastUsed);
                            });
                            break;
                    }

                    // Update the skills listbox
                    UpdateSkillsListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateSkillsListBox()
        {
            try
            {
                // Clear the listbox
                if (SkillsListBox.Items.Count > 0)
                {
                    SkillsListBox.Items.Clear();
                }

                // Add all the skills to the listbox
                SkillsListBox.SuspendLayout();
                for (int i = 0; i < Skills.Count; i++)
                {
                    SkillsListBox.Items.Add(Skills[i]);
                }
                SkillsListBox.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveSkills()
        {
            try
            {
                // Clear existing skills
                Settings.Default.Skills.Clear();

                // Add each skill as json
                foreach (Skill skill in Skills)
                {
                    Settings.Default.Skills.Add(JsonSerializer.Serialize(skill));
                }

                // Save
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSkillButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Display a form for adding a new skill
                AddSkillForm addSkillForm = new();
                if (addSkillForm.ShowDialog() == DialogResult.OK && addSkillForm.SkillTextBox.Text != "")
                {
                    // Make sure the skill isn't already in the skills list
                    Skill skill = new() { Name = addSkillForm.SkillTextBox.Text };
                    if (Skills.Contains(skill) == false)
                    {
                        // Add the new skill
                        Skills.Add(skill);

                        // Save skills
                        SaveSkills();

                        // Update the skills listbox
                        UpdateSkillsListBox();

                        // Display which skill was added
                        StatusTextBox.AppendText("\r\n" + skill.Name + " was added");
                    }
                }

                // Clean up
                addSkillForm.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteSkillButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure something is selected
                if (SkillsListBox.SelectedItem != null)
                {
                    string? selectedItem = SkillsListBox.SelectedItem.ToString();
                    if (selectedItem != null)
                    {
                        // Find the selected skill
                        List<string> splitItem = selectedItem.Split(" | ").ToList();
                        Skill? skill = Skills.Find(x => x.Name == splitItem[0]);
                        if (skill != null)
                        {
                            // Delete the selected skill
                            Skills.Remove(skill);

                            // Save skills
                            SaveSkills();

                            // Update the skills listbox
                            UpdateSkillsListBox();

                            // Display which skill was deleted
                            StatusTextBox.AppendText("\r\n" + skill.Name + " was deleted");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UseSkillButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure something is selected
                if (SkillsListBox.SelectedItem != null)
                {
                    // Display a form for using a skill
                    UseSkillForm useSkillForm = new();
                    if (useSkillForm.ShowDialog() == DialogResult.OK)
                    {
                        string? selectedItem = SkillsListBox.SelectedItem.ToString();
                        if (selectedItem != null)
                        {
                            // Find the skill to use
                            List<string> splitItem = selectedItem.Split(" | ").ToList();
                            Skill? skill = Skills.Find(x => x.Name == splitItem[0]);
                            if (skill != null)
                            {
                                // Use RNG to determine if skill level should increase
                                Random random = new();
                                decimal totalIncrease = 0.0m;
                                for (int i = 0; i < int.Parse(useSkillForm.TimeSpentComboBox.Text); i++)
                                {
                                    // Make skill gain become increasingly difficult as skill level increases
                                    if ((decimal)(random.NextDouble() * 100) > skill.Level)
                                    {
                                        skill.Level += 0.1m;
                                        totalIncrease += 0.1m;
                                    }
                                }

                                // Update last used
                                skill.LastUsed = DateTime.Now;

                                // Save skills
                                SaveSkills();

                                // Update the skills listbox
                                UpdateSkillsListBox();

                                // Display the skill's total increase
                                StatusTextBox.AppendText("\r\n" + skill.Name + " has increased by " + totalIncrease.ToString("F1"));
                            }
                        }
                    }

                    // Clean up
                    useSkillForm.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}