using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeLigaNoBlog.Test
{
    [TestClass]
    public class UsuarioTests
    {
        [TestMethod]
        public void DeveAtribuirValoresAsPropriedades()
        {
            //Arrange
            var nome = "João das Couves";
            var email = "jcouves@gmail.com";

            //Act
            var usuario = new Usuario(nome, email);

            //Assert
            Assert.AreEqual(nome, usuario.Nome);
            Assert.AreEqual(email, usuario.Email);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveAceitarNomeNulo()
        {
            //Act
            var usuario = new Usuario(null, "jcouves@gmail.com");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NaoDeveAceitarEmailNulo()
        {
            //Act
            var usuario = new Usuario("João das Couves", null);
        }
    }
}
