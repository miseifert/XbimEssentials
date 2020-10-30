// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.TopologyResource;
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
	[ExpressType("IfcManifoldSolidBrep", 149)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcManifoldSolidBrep : IfcSolidModel, IEquatable<@IfcManifoldSolidBrep>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcManifoldSolidBrep(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcClosedShell _outer;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcClosedShell @Outer 
		{ 
			get 
			{
				if(_activated) return _outer;
				Activate();
				return _outer;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _outer = v, _outer, value,  "Outer", 1);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_outer = (IfcClosedShell)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcManifoldSolidBrep other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}