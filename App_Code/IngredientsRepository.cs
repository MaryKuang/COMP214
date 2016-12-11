using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IngredientsRepository
/// </summary>
public class IngredientsRepository
{
    public IngredientsRepository()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public List<Ingredients> GetIngredients()
    {
        HttpApplication webApp = HttpContext.Current.ApplicationInstance;
        //  return (List<Ingredients>)webApp.Application["Ingredients"];
        return (List<Ingredients>)webApp.Session["Ingredients"];

    }

    public void Update(Ingredients aIngredient)
    {

    }
}