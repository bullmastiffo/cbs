/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Dolittle.Validation;
using FluentValidation;

namespace Concepts.HealthRisk
{
    public class HealthRiskReadableIdValidator : InputValidator<HealthRiskReadableId>
    {
        public HealthRiskReadableIdValidator()
        {
            RuleFor(_ => _.Value)
                .Must(BeValid).WithMessage($"HealthRisk ReadableId cannot be {HealthRiskReadableId.NotSet}");
        }

        bool BeValid(int readableId)
        {
            return readableId != HealthRiskReadableId.NotSet;
        }
    }
}