using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Recipe
/// </summary>
public class Recipe
{
    
    private string recipeName;
    public string RecipeName
    {
        get
        {
            return recipeName;
        }

        set
        {
            recipeName = value;
        }
    }
    private string authorName;
    public string AuthorName
    {
        get
        {
            return authorName;
        }

        set
        {
            authorName = value;
        }
    }

    private string category;
    public string Category
    {
        get
        {
            return category;
        }

        set
        {
            category = value;
        }
    }
    private string cookingTime;
    public string CookingTime
    {
        get
        {
            return cookingTime;
        }

        set
        {
           cookingTime = value;
        }
    }
    private string servingNumber;
    public string ServingNumber
    {
        get
        {
            return servingNumber;
        }

        set
        {
            servingNumber = value;
        }
    }


    private string description;
    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            description = value;
        }
    }

    List<Ingredients> ingredients;
    public List<Ingredients> Ingredients
    {
        get { return ingredients; }
        set { ingredients = value; }
    }

    public Recipe()
    {
        //
        // TODO: Add constructor logic here
        //
        this.ingredients = new List<Ingredients>();
    }

}