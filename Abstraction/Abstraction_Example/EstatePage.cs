using Abstraction_Example.Business.Repositories;
using Abstraction_Example.Business.Repositories.Concrete;
using Abstraction_Example.Model.Entity.Concrete;
using Abstraction_Example.Model.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction_Example
{
    public partial class EstatePage : Form
    {
        public EstatePage()
        {
            InitializeComponent();
        }
        EstateRepository estateRepository = new EstateRepository();

        private void EstatePage_Load(object sender, EventArgs e)
        {
            //cmb_create.DataSource = Enum.GetValues(typeof(PropertyRental));
            //cmb_create.SelectedIndex = -1;

            //cmb_update.DataSource = Enum.GetValues(typeof(PropertyRental));
            //cmb_update.SelectedIndex = -1;

            estateRepository.GetByRental(cmb_create);

            estateRepository.GetByRental(cmb_update);

            estateRepository.GetByRental(cmb_getPropertyRental);


            dataGridView1.DataSource = estateRepository.GetAll();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Estate estate = new Estate();
            estate.Id = int.Parse(txt_create_Id.Text);
            estate.PropertyRental = cmb_create.Text;
            estate.Description = txtCreate_Description.Text;
            estate.Adress = txtCreate_Adress.Text;
            estate.Price = Convert.ToInt32(txtCreate_Price.Text);
            estateRepository.Create(estate);
            dataGridView1.DataSource = estateRepository.GetAll();
            Utilities.Eraser(grp_create);
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_find_Id.Text);
            Estate estate = estateRepository.GetById(id);
            cmb_update.Text = estate.PropertyRental;
            txtUpdate_Description.Text = estate.Description;
            txtUpdate_Adress.Text = estate.Adress;
            txtUpdate_Price.Text = estate.Price.ToString();
            dataGridView1.DataSource = estateRepository.GetAll();
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Estate estate = new Estate();
            estate.Id = int.Parse(txt_find_Id.Text);
            estate.PropertyRental = cmb_update.Text;
            estate.Description = txtUpdate_Description.Text;
            estate.Adress = txtUpdate_Adress.Text;
            estate.Price = Convert.ToInt32(txtUpdate_Price.Text);
            estateRepository.Update(estate);
            dataGridView1.DataSource = estateRepository.GetAll();
            Utilities.Eraser(grp_update);

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_delete_Id.Text);
            Estate estate = estateRepository.GetById(id);
            estateRepository.Delete(estate);
            dataGridView1.DataSource=estateRepository.GetAll();
            Utilities.Eraser(grp_delete);
            
        }

        private void btn_getDescription_Click(object sender, EventArgs e)
        {
            List<Estate> estate = estateRepository.GetByDescription(txt_getDescription.Text);
            dataGridView1.DataSource = estate;
        }

        private void btn_rental_Click(object sender, EventArgs e)
        {
            List<Estate> estate = estateRepository.GetByProperty(cmb_getPropertyRental.Text);
            dataGridView1.DataSource = estate;
        }

        private void btn_Price_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_price.Text);
            Estate estate = estateRepository.GetByPrice(id);
            dataGridView1.DataSource = new List<Estate>(){estate}; 
        }
    }
}
