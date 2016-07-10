using System;
using Xunit;

namespace DotNetCore_XUnit.Test
{
    public class Tests : IDisposable
    {
        private App _target;

        // setup
        public Tests()
        {
            _target = new App();
        }

        // teardown
        public void Dispose()
        {
            if (_target == null) return;
            
            //_target.Dispose();
            _target = null;
        }

        [Fact]
        public void CanGetInstance()
        {
            Assert.NotNull(_target);      
        }
    }    
}
