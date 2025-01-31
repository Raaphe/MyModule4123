﻿// MIT License
// Copyright Eraware

using Eraware.Modules.MyModule.Services.Localization;
using FluentValidation;

namespace Eraware.Modules.MyModule.Services.Items
{
    /// <summary>
    /// Validator for the <see cref="UpdateItemDTO"/> entity.
    /// </summary>
    internal class UpdateItemDtoValidator : AbstractValidator<UpdateItemDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItemDtoValidator"/> class.
        /// </summary>
        /// <param name="localizationService">The localization service.</param>
        public UpdateItemDtoValidator(ILocalizationService localizationService)
        {
            var modelValidationViewModel = localizationService.ViewModel.ModelValidation;

            this.Include(new CreateItemDtoValidator(localizationService));

            this.RuleFor(x => x.Id)
               .GreaterThan(0)
               .WithMessage(modelValidationViewModel.IdGreaterThanZero);
        }
    }
}
