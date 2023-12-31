// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using Xbim.Common;

namespace Xbim.Ifc4x3
{
    public class ItemSet<T> : Common.Collections.ItemSet<T>
    {
        internal ItemSet(IPersistEntity entity, int capacity, int property): base(entity, capacity, property)
        {
        }

		//this is to be only used internally to add object outside of any transaction or event firing
		//that is typically during parsing operation
		internal void InternalAdd(T value)
		{
			Internal.Add(value);
		}
		
        internal T InternalGetAt(int index)
        {
            if (index < Count)
                return this[index];

            if (index > Count)
                throw new Exception("It is not possible to get object which is more that just the next after the last one.");
            
            if (!typeof (IItemSet).IsAssignableFrom(typeof (T)))
                return default(T);

            var result = CreateNestedSet();
            InternalAdd(result);
            return result;

        }
    }
}
