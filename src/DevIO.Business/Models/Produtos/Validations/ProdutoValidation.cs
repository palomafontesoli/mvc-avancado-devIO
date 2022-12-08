﻿using FluentValidation;

namespace DevIO.Business.Models.Produtos.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser preenchido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres");
            RuleFor(p => p.Descricao)
                .NotEmpty().WithMessage("O campo { PropertyName} precisa ser preenchido")
                .Length(2, 1000).WithMessage("O campo { PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres");
            RuleFor(p => p.Valor)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}