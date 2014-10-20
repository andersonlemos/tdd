using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
namespace Copiadora
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void DeveLerEEnviarOConteudoLido()
        {
            var e = new Mock<IEscritor>();
            var l =  new Mock<ILeitor>();

            e.Setup(r => t.TemCaracteres()).Returns( new Queue<bool>(new []{true,false}).Dequeue);

            l.Setup(t => t.LeCaracteres()).Returns("mauricio");

            Copiadora c = new Copiadora(l.Object, e.Object);

            c.Copiar();

            e.Verify(t => t.Escreve("mauricio"))
;

        }
    }
}
