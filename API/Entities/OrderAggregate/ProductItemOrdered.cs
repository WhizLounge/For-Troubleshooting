using System;
using Microsoft.EntityFrameworkCore;

namespace API.Entities;

[Owned]
public class ProductItemOrdered
{
public int ProductId { get; set; }
public required string Name { get; set; }
public required string PictureUrl { get; set; }
}
