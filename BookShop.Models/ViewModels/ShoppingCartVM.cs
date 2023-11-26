using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models.ViewModels
{
	public class ShoppingCartVM
	{
		public IEnumerable<ShoppingCart>? ShoppingCartsList { get; set; }

		public OrderHeader? OrderHeader { get; set; }
	}
}
