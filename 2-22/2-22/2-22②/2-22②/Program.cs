// See https://aka.ms/new-console-template for more information

using System;

interface IBillable
{
    int CostForDay(int hoursWorked);
}

class FullTimeEmployee : IBillable
{
    public int CostForDay(int hoursWorked) => 1250 * hoursWorked;
}

class ContractEmployee : IBillable
{
    public int CostForDay(int hoursWorked) => 1000 * hoursWorked;
}