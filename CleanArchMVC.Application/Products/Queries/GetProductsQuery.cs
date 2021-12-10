using System.Collections.Generic;
using CleanArchMVC.Domain.Entities;
using MediatR;

namespace CleanArchMVC.Application.Products.Queries
{
    public class GetProductsQuery: IRequest<IEnumerable<Product>>
    {
        
    }
}