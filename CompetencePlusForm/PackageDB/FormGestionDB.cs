using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageDB
{
    public partial class FormGestionDB : Form
    {
        public FormGestionDB()
        {
            InitializeComponent();
        }
        private void FormGestionDB_Load(object sender, EventArgs e)
        {
            this.refresh();

        }
        #region facilitateur
        public void refresh()
        {
            incrementationDBBindingSource.DataSource = new IncrementDB_BAO().Select();
        }
        private void charger(IncrementationDB increment)
        {
            IncTextBox.Text = increment.Increment;
            //DecTextBox.Text = increment.Decrement;
            textBoxTitre.Text = increment.Titre;
        }
        #endregion

        #region  Action
        /// <summary>
        /// Enregistrer sans exécuter le la requête sur la base de données actuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Est ce que vous savez déja exécuter cette requête sur votre base de données ?", "Confirmation d'exécution sur Acces", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                IncrementationDB incrementation = new IncrementationDB();
                incrementation.Increment = IncTextBox.Text;
                //inc.Decrement = DecTextBox.Text;
                incrementation.Titre = textBoxTitre.Text;
                try
                {
                    new IncrementDB_BAO().SaveWithOutExecut(incrementation);
                    refresh();
                    MessageBox.Show("La requête sera exécuter automatiquement dans la prochaine exécution de l'application");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {

                MessageBox.Show("Alors, dans ce cas Utilisez le button 'Enregistrer avec exécution automatique'");
            }

        }
        /// <summary>
        /// Exécuter la requête SQL ensuite création du fichier XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtExecute_Click(object sender, EventArgs e)
        {
            IncrementationDB inc = new IncrementationDB();
            inc.Increment = IncTextBox.Text;
            //inc.Decrement = DecTextBox.Text;
            inc.Titre = textBoxTitre.Text;
            try
            {
                new IncrementDB_BAO().Execut(inc);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            IncrementationDB inc = (IncrementationDB)incrementationDBBindingSource.Current;
            new IncrementDB_BAO().Delete(inc);
            this.refresh();
        }
        #endregion
  


        #region  Navigation

        private void btSuivant_Click(object sender, EventArgs e)
        {
            incrementationDBBindingSource.MoveNext();
        }

        private void brPrecedent_Click(object sender, EventArgs e)
        {
            incrementationDBBindingSource.MovePrevious();
        }
        #endregion
       
        #region  Template
        private void btCreateTable_Click(object sender, EventArgs e)
        {
            IncrementationDB inc = new IncrementDB_BAO().TemplteCreateTable();
            this.charger(inc);

        }

        #endregion

        #region Valisation d'interface
        private void IncTextBox_TextChanged(object sender, EventArgs e)
        {
            String[] ls;
            ls = IncTextBox.Text.Split();
            textBoxTitre.Text = ls[0];
            for (int i = 1; i < 3 && i < (ls.Length - 1); i++)
            {
                textBoxTitre.Text += "-" + ls[i];
            }

        }
        #endregion

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            IncrementationDB incrementation =(IncrementationDB) incrementationDBBindingSource.Current;
            incrementation.Titre = textBoxTitre.Text;
            incrementation.Increment = IncTextBox.Text;
            new IncrementDB_BAO().Update(incrementation);
            this.refresh();

        }













    }
}
