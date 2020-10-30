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
	[ExpressType("IfcCartesianPointList2D", 1117)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianPointList2D : IfcCartesianPointList, IInstantiableEntity, IEquatable<@IfcCartesianPointList2D>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianPointList2D(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_coordList = new ItemSet<IItemSet<IfcLengthMeasure>>( this, 0,  1);
			_tagList = new OptionalItemSet<IfcLabel>( this, 0,  2);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IItemSet<IfcLengthMeasure>> _coordList;
		private readonly OptionalItemSet<IfcLabel> _tagList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, new int [] { 1, 2 }, new int [] { -1, 2 }, 3)]
		public IItemSet<IItemSet<IfcLengthMeasure>> @CoordList 
		{ 
			get 
			{
				if(_activated) return _coordList;
				Activate();
				return _coordList;
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 4)]
		public IOptionalItemSet<IfcLabel> @TagList 
		{ 
			get 
			{
				if(_activated) return _tagList;
				Activate();
				return _tagList;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					((ItemSet<IfcLengthMeasure>)_coordList
						.InternalGetAt(nestedIndex[0]) )
						.InternalAdd((IfcLengthMeasure)(value.RealVal));
					return;
				case 1: 
					_tagList.InternalAdd(value.StringVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianPointList2D other)
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