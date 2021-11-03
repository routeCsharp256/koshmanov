﻿using System.Collections.Generic;
using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregationModels.NamesAggregate
{
    public class Patronymic:ValueObject
    {
        public Patronymic(string value)
        {
            Value = value;
        }
        public string Value { get;}

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}