using System;
using Xunit;

namespace Lab.Tests
{
    public class UnitTest1
    {
       /// <summary>
        /// Test Unitario para rut sin guion
        /// </summary>
        [Fact]
        public void retornarExcepcionPorGuionVerificador()
        {
            var persona = new Persona();
            persona.Rut = "194460880";

            Exception ex = Assert.Throws<ArgumentException>(() => persona.validate());

            Assert.Equal("RUT invalido", ex.Message);
        }
    }
}
