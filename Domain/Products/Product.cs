﻿namespace IPediApp.Domain.Products;

public class Product : Entity
{
    //guid permite que geramos o id da forma que queremos
    public string Name { get; set; }
    public string Description{ get; set; }
    public Category Category { get; set; }
    public bool hasStock { get; set; }
    
}