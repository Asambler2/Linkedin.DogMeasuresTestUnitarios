using System.Collections.Generic;
using Linkedin.DogMeasures.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Linkedin.DogMeasures.Services
{
    public class ServicioParaProbar
    {

        public readonly List<DogWeightInfo> _weightInfos;
        public ServicioParaProbar()
        {
            _weightInfos = new List<DogWeightInfo>
            {
                new DogWeightInfo()
                {
                    Message = "Estas muy gordo", DeviationType = DogWeightInfo.WeightDeviationType.Overweight,
                    WeightDeviation = 0.4M
                },
                new DogWeightInfo()
                {
                    Message = "Estas muy delgado", DeviationType = DogWeightInfo.WeightDeviationType.BelowWeight,
                    WeightDeviation = 0.1M
                },
                new DogWeightInfo()
                {
                    Message = "Estas excelente", DeviationType = DogWeightInfo.WeightDeviationType.InRange,
                    WeightDeviation = 0.05M
                },
            };


        }

        public decimal DameDesviacion(DogWeightInfo.WeightDeviationType tipo)
        {
            switch (tipo)
            {
                case DogWeightInfo.WeightDeviationType.InRange:
                    return 0.5M;
                case DogWeightInfo.WeightDeviationType.Overweight:
                    return 0.8M;
                case DogWeightInfo.WeightDeviationType.BelowWeight:
                    return 1.0M;
                default: return 0;
            }

        }
    }
}