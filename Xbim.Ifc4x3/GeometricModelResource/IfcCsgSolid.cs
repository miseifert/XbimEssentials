// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

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
	[ExpressType("IfcCsgSolid", 548)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCsgSolid : IfcSolidModel, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcCsgSolid>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCsgSolid(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCsgSelect _treeRootExpression;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCsgSelect @TreeRootExpression 
		{ 
			get 
			{
				if(_activated) return _treeRootExpression;
				Activate();
				return _treeRootExpression;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _treeRootExpression = v, _treeRootExpression, value,  "TreeRootExpression", 1);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_treeRootExpression = (IfcCsgSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCsgSolid other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@TreeRootExpression != null)
					yield return @TreeRootExpression;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}