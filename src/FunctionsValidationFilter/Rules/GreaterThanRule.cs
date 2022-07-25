﻿namespace NewDay.Extensions.FunctionsValidationFilter.Rules;

internal class GreaterThanRule : Rule
{
    public int ValueToCompare { get; }

    public GreaterThanRule(int valueToCompare)
    {
        ValueToCompare = valueToCompare;
    }
}
