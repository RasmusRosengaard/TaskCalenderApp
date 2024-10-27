using System;
using System.ComponentModel.DataAnnotations;

public class DateRange : ValidationAttribute
{
    private readonly int _minYearsBack;
    private readonly int _maxYearsForward;

    public DateRange(int minYearsBack, int maxYearsForward)
    {
        _minYearsBack = minYearsBack;
        _maxYearsForward = maxYearsForward;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateValue)
        {
            var today = DateTime.Today;
            var minDate = today.AddYears(-_minYearsBack);
            var maxDate = today.AddYears(_maxYearsForward);

            if (dateValue < minDate || dateValue > maxDate)
            {
                return new ValidationResult($"Date must be between {minDate.ToShortDateString()} and {maxDate.ToShortDateString()}.");
            }
        }
        return ValidationResult.Success;
    }
}
