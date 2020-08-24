using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectionsReductionsLibrary
{
	public class DirReduction
	{

		public static bool RemoveItem(KeyValuePair<string, string> pairToRemove, List<string> items)
		{
			var indexOf = items.IndexOf(pairToRemove.Key);
			//make sure that you can handle the case when you are at the end
			if (indexOf > -1 && items.ElementAtOrDefault(indexOf + 1) == pairToRemove.Value)
			{
				//Now remove current and next
				items.RemoveRange(indexOf, 2);
				//items.Dump();
				return true;
			}
			return false;
		}

		public static string[] dirReduc(String[] arr)
		{
			if(arr == null || arr.Length == 0)
            {
				return Array.Empty<string>();
            }
			
            Dictionary<string, string> keysThatCancelOut = new Dictionary<string, string>
            {
                { "NORTH", "SOUTH" },
                { "SOUTH", "NORTH" },
                { "EAST", "WEST" },
                { "WEST", "EAST" }
            };
            List<string> al = new List<string>(arr);

			for (int i = 0; i < keysThatCancelOut.Count; i++)
			{
				bool removed = RemoveItem(keysThatCancelOut.ElementAt(i), al);
				if (removed)
				{
					//start at the beginning again to reveiw the duplicates
					i = 0;
				}
			}

			return al.ToArray();
		}


	}



}
