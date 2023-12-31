// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometricModelResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricModelResource
{
	[ExpressType("IfcTriangulatedIrregularNetwork", 1357)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTriangulatedIrregularNetwork : IfcTriangulatedFaceSet, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcTriangulatedIrregularNetwork>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTriangulatedIrregularNetwork(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_flags = new ItemSet<IfcInteger>( this, 0,  6);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcInteger> _flags;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 10)]
		public IItemSet<IfcInteger> @Flags 
		{ 
			get 
			{
				if(_activated) return _flags;
				Activate();
				return _flags;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_flags.InternalAdd(value.IntegerVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTriangulatedIrregularNetwork other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Coordinates != null)
					yield return @Coordinates;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}