using System;

namespace Decorator
{
    // The base Decorator class follows the same interface as the other
    // components. The primary purpose of this class is to define the wrapping
    // interface for all concrete decorators. The default implementation of the
    // wrapping code might include a field for storing a wrapped component and
    // the means to initialize it.
    abstract class Decorator : Component
    {
        protected Component _item;

        public Decorator(Component component)
        {
            this._item = component;
        }

        public void SetComponent(Component cmp)
        {
            this._item = cmp;
        }

        // The Decorator delegates all work to the wrapped component.
        public override string PerformAction()
        {
            if (this._item != null)
            {
                return this._item.PerformAction();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}


