﻿using IPediApp.Domain.Products;
using IPediApp.infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace IPediApp.Endpoint.Categories;

public class CategoryPut
{
    public static string Template => "/categories/{id}";
    public static string[] Methods => new string[] { 
        HttpMethod.Put.ToString()
    };

    public static Delegate Handle => Action;

    public static IResult Action([FromRoute] Guid id, CategoryRequest categoryRequest, ApplicationDbContext context )
    {
        var category = context.Categories.Where(c => c.Id == id).FirstOrDefault();

        if (category == null) return Results.NotFound();

        category.Name = categoryRequest.Name;
        category.Active = categoryRequest.Active;

        context.SaveChanges();

        return Results.Ok();
    }







}
