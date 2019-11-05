using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTest.Validators
{
    public class ProductNameValidator : ValidationAttribute
    {
        
        public ProductNameValidator()
        {
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                ErrorMessage = "Name cannot be empty";
                return false;
            }

            if (value is String)
            {
                String converter = value.ToString();
                if (converter.Length > 20 && converter.Length > 1)
                {
                    ErrorMessage = "Name cannot be more then 20";
                    return false;
                }
            }
            return true;
        }
    }
}