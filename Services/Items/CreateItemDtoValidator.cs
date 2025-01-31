﻿// MIT License
// Copyright Eraware

using Eraware.Modules.MyModule.Services.Localization;
using FluentValidation;

namespace Eraware.Modules.MyModule.Services.Items
{
    /// <summary>
    /// Validates the <see cref="CreateItemDTO"/>.
    /// </summary>
    public class CreateItemDtoValidator : AbstractValidator<CreateItemDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateItemDtoValidator"/> class.
        /// </summary>
        /// <param name="localizationService">The localization service.</param>
        public CreateItemDtoValidator(ILocalizationService localizationService)
        {
            var modelValidationViewModel = localizationService.ViewModel.ModelValidation;

            this.RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(modelValidationViewModel.NameRequired);
        }
    }
}
