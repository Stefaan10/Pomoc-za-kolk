using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Veterinari : Form
    {
        private readonly VetBusiness vetBusiness;
        public Veterinari()
        {
            this.vetBusiness = new VetBusiness();
            InitializeComponent();
        }

        void refresh()
        {
            List<Vet> v = this.vetBusiness.GetAllVets();
            dataGridView1.DataSource = v;
            dataGridView2.DataSource = v;
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text != "" && tbSpecialty.Text != "" && tbYearsExperience.Text != "")
            {
                Vet v = new Vet();
                v.FullName = tbFullName.Text;
                v.Specialty = tbSpecialty.Text;
                v.YearsExperience = Convert.ToInt32(tbYearsExperience.Text);
                this.vetBusiness.InsertVets(v);
                refresh();
                tbFullName.Text = "";
                tbSpecialty.Text = "";
                tbYearsExperience.Text = "";
                MessageBox.Show("Dodato je u bazu vet", "Message");
            }
            else
                MessageBox.Show("UNESI SVA POLJA!", "Message");
        }

        private void Veterinari_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnShowRange_Click(object sender, EventArgs e)
        {
            try
            {
                int experienceThreshold = Convert.ToInt32(tbRange.Text);

                // Dohvati veterinare sa vise iskustva od zadatog praga
                List<Vet> vets = vetBusiness.GetVetsWithExperienceGreaterThan(experienceThreshold);

                dataGridView2.DataSource = vets;

                MessageBox.Show("Prikazani su u okviru zadatog iskustva.", "Poruka");
            }
            catch (FormatException)
            {
                MessageBox.Show("Molimo unesite ispravan broj za iskustvo.", "Greška");
            }

        }

        /* NE ZABORAVI ID!!! */

        int ID;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text != "" || tbSpecialty.Text != "" || tbYearsExperience.Text != "")
            {
                Vet v = new Vet();
                v.FullName = tbFullName.Text;
                v.Specialty = tbSpecialty.Text;
                v.YearsExperience = Convert.ToInt32(tbYearsExperience.Text);
                v.Id = ID;

                this.vetBusiness.UpdateVets(v);
                MessageBox.Show("Azurirano je u bazu vet", "Message");

                refresh();
                tbFullName.Text = "";
                tbSpecialty.Text = "";
                tbYearsExperience.Text = "";    
            }
            else
                MessageBox.Show("UNESI BAR 1 PODATAK ZA AZURIRANJE!!!", "Message");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                Vet v = new Vet();
                v.Id = selectedId;

                if (this.vetBusiness.DeleteVets(v))
                {
                    refresh();
                    tbFullName.Text = "";
                    tbSpecialty.Text = "";
                    tbYearsExperience.Text = "";
                    MessageBox.Show("Izabrani vet je uspešno obrisan iz baze!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Neuspešno brisanje!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da prvo izaberete veterinarskog stručnjaka za brisanje.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // NE DUPLI KLIK NA DATAGRIDVIEW!!! RESENJE JE U DIZAJNERSKOM DELU U EVENTOVIMA
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                tbFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbSpecialty.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbYearsExperience.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void rbVeciOd10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVeciOd10.Checked)
            {
                // Dohvati veterinare sa više iskustva od 10 godina
                List<Vet> vets = vetBusiness.GetVetsWithExperienceGreaterThan(10);

                // Postavi DataSource za dataGridView2
                dataGridView2.DataSource = vets;
            }
        }

        private void rbManjiOd50_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManjiOd50.Checked)
            {
                // Dohvati veterinare sa manje iskustva od 50 godina
                List<Vet> vets = vetBusiness.GetVetsWithExperienceLessThan(50);

                // Postavi DataSource za dataGridView2
                dataGridView2.DataSource = vets;
            }
        }

        private void chckbxImeVeceOd10_CheckedChanged(object sender, EventArgs e)
        {

            if (chckbxImeVeceOd10.Checked)
            {
                List<Vet> vets = vetBusiness.GetVetsWithFullNameLengthGreaterThan(10);

                dataGridView2.DataSource = vets;
            }
            else
            {
                refresh();
            }
        }

        private void tbYearsExperience_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
