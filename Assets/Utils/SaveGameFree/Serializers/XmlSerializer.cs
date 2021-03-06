using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace SaveGameFree.Serializers
{

	/// <summary>
	/// Xml Serialization for Save Game Free.
	/// </summary>
	public class XmlSerializer : ISerializer
	{
		
		#region ISerializer implementation

		/// <summary>
		/// Serialize the specified object to specified file path.
		/// </summary>
		/// <param name="obj">Object.</param>
		/// <param name="filePath">File path.</param>
		public void Serialize ( object obj, string filePath )
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer ();
				serializer.Serialize ( obj, filePath );
			}
			catch ( Exception ex )
			{
				Debug.LogException ( ex );
			}
		}

		/// <summary>
		/// Deserialize object from the specified filePath.
		/// </summary>
		/// <param name="filePath">File path.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public T Deserialize<T> ( string filePath )
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer ();
				return serializer.Deserialize<T> ( filePath );
			}
			catch ( Exception ex )
			{
				Debug.LogException ( ex );
			}
			return default(T);
		}

		#endregion

	}

}