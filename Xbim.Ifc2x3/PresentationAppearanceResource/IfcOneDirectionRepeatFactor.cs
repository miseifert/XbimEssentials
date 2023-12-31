// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcOneDirectionRepeatFactor", 32)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOneDirectionRepeatFactor : IfcGeometricRepresentationItem, IInstantiableEntity, IfcHatchLineDistanceSelect, IContainsEntityReferences, IEquatable<@IfcOneDirectionRepeatFactor>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOneDirectionRepeatFactor(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcVector _repeatFactor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcVector @RepeatFactor 
		{ 
			get 
			{
				if(_activated) return _repeatFactor;
				Activate();
				return _repeatFactor;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _repeatFactor = v, _repeatFactor, value,  "RepeatFactor", 1);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_repeatFactor = (IfcVector)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOneDirectionRepeatFactor other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RepeatFactor != null)
					yield return @RepeatFactor;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}