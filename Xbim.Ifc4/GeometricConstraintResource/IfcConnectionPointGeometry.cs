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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConnectionPointGeometry
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConnectionPointGeometry : IIfcConnectionGeometry
	{
		IIfcPointOrVertexPoint @PointOnRelatingElement { get;  set; }
		IIfcPointOrVertexPoint @PointOnRelatedElement { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcConnectionPointGeometry", 71)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionPointGeometry : IfcConnectionGeometry, IInstantiableEntity, IIfcConnectionPointGeometry, IContainsEntityReferences, IEquatable<@IfcConnectionPointGeometry>
	{
		#region IIfcConnectionPointGeometry explicit implementation
		IIfcPointOrVertexPoint IIfcConnectionPointGeometry.PointOnRelatingElement { 
 
 
			get { return @PointOnRelatingElement; } 
			set { PointOnRelatingElement = value as IfcPointOrVertexPoint;}
		}	
		IIfcPointOrVertexPoint IIfcConnectionPointGeometry.PointOnRelatedElement { 
 
 
			get { return @PointOnRelatedElement; } 
			set { PointOnRelatedElement = value as IfcPointOrVertexPoint;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionPointGeometry(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPointOrVertexPoint _pointOnRelatingElement;
		private IfcPointOrVertexPoint _pointOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcPointOrVertexPoint @PointOnRelatingElement 
		{ 
			get 
			{
				if(_activated) return _pointOnRelatingElement;
				Activate();
				return _pointOnRelatingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _pointOnRelatingElement = v, _pointOnRelatingElement, value,  "PointOnRelatingElement", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcPointOrVertexPoint @PointOnRelatedElement 
		{ 
			get 
			{
				if(_activated) return _pointOnRelatedElement;
				Activate();
				return _pointOnRelatedElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _pointOnRelatedElement = v, _pointOnRelatedElement, value,  "PointOnRelatedElement", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_pointOnRelatingElement = (IfcPointOrVertexPoint)(value.EntityVal);
					return;
				case 1: 
					_pointOnRelatedElement = (IfcPointOrVertexPoint)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConnectionPointGeometry other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@PointOnRelatingElement != null)
					yield return @PointOnRelatingElement;
				if (@PointOnRelatedElement != null)
					yield return @PointOnRelatedElement;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}