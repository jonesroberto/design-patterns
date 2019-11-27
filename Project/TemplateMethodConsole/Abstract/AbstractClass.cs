using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodConsole
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
