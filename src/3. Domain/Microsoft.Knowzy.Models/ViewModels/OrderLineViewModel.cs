﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.Knowzy.Models.ViewModels.Validators;

namespace Microsoft.Knowzy.Models.ViewModels
{
    public class OrderLineViewModel : IValidatableObject
    {
        public int Id { get; set; }
        [Display(Name = "Item number")]
        public string ItemNumber { get; set; }
        [Display(Name = "Item image")]
        public string ItemImage { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var validator = new OrderLineViewModelValidator();
            var result = validator.Validate(this);
            return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
        }
    }
}