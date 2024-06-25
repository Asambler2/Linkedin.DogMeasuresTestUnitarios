using Microsoft.VisualStudio.TestTools.UnitTesting;
using Linkedin.DogMeasures.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linkedin.DogMeasures.Models;

namespace TestServicioParaProbar.Tests
{
    [TestClass()]
    public class ServicioParaProbarTests
    {
        ServicioParaProbar servicio = new ServicioParaProbar();


        [TestMethod]
        public void ServicioParaProbarTest()
        {
            Assert.IsNotNull(servicio);
            Assert.IsInstanceOfType(servicio, typeof(ServicioParaProbar));
        }

        [TestMethod]
        public void ServicioParaProbarTestConLista()
        {
            Assert.AreEqual(3, servicio._weightInfos.Count);
            Assert.IsInstanceOfType(servicio._weightInfos, typeof(List<DogWeightInfo>));
            Assert.IsInstanceOfType(servicio._weightInfos[0], typeof(DogWeightInfo));
        }

        [TestMethod()]
        public void DameDesviacionTest()
        {
            Assert.AreEqual(0.5M, servicio.DameDesviacion(DogWeightInfo.WeightDeviationType.InRange));
            Assert.AreEqual(0.8M, servicio.DameDesviacion(DogWeightInfo.WeightDeviationType.Overweight));
            Assert.AreEqual(1M, servicio.DameDesviacion(DogWeightInfo.WeightDeviationType.BelowWeight));
        }
    }
}