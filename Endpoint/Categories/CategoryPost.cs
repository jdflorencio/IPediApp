﻿using IPediApp.Domain.Products;
using IPediApp.infra.Data;

namespace IPediApp.Endpoint.Categories;

public class CategoryPost
{
    public static string Template => "/categoires";
    public static string[] Methods => new string[] { 
        HttpMethod.Post.ToString()
    };

    public static Delegate Handle => Action;

    public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context )
    {
        var category = new Category
        {
            Name = categoryRequest.Name,
        };

        context.Categories.Add( category );
        context.SaveChanges();

        return Results.Created($"/categories/{category.Id}", category.Id);
    }







}
