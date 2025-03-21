﻿using MediatR;

namespace Catalog.Products.Features;

public record CreateProductCommand
    (string Name, List<string> Category, string Description, string ImageFile, decimal Price) : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        // business logic
        return null;
    }
}
