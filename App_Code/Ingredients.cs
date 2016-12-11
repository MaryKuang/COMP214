using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ingredients
/// </summary>
public class Ingredients
{
    public Ingredients()
    {
        //
        // TODO: Add constructor logic here
        ingredientName = "";
        quantity = "";
        unitName = "";

        
    }
    private string ingredientName;
    public string IngredientName
    {
        get
        {
            return ingredientName;
        }

        set
        {
            ingredientName = value;
        }
    }
    private string quantity;
    public string Quantity
    {
        get
        {
            return quantity;
        }

        set
        {
            quantity = value;
        }
    }
    private string unitName;
    public string UnitName
    {
        get
        {
            return unitName;
        }

        set
        {
            unitName = value;
        }
    }
    private int recipeID;
    public int RecipeID
    {
        get
        {
            return recipeID;
        }

        set
        {
            recipeID = value;
        }
    }




}