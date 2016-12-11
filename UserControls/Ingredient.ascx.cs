using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ingredient : System.Web.UI.UserControl
{
    
    protected List<Ingredients> ingredients;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Ingredients"] != null)
        {
            ingredients = (List<Ingredients>)Session["Ingredients"];
        }
        else
        {
            ingredients = new List<Ingredients>();
            Session["Ingredients"] = ingredients;
        }

    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Ingredients item = new Ingredients();
        item.IngredientName = txtBoxIngredient.Text;
        item.Quantity = txtBoxMeasure.Text;
        item.UnitName = txtBoxUnit.Text;

        if (item.IngredientName.Length + item.Quantity.Length + item.UnitName.Length > 0)
        {
            ingredients.Add(item);
            ListView1.DataBind();
            txtBoxIngredient.Text = "";
            txtBoxMeasure.Text = "";
            txtBoxUnit.Text = "";
        }
        if (15 == ingredients.Count)
        {
            txtBoxIngredient.Enabled = false;
            txtBoxMeasure.Enabled = false;
            txtBoxUnit.Enabled = false;
            btnAdd.Enabled = false;
        }
    }
}

    
   