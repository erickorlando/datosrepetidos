using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DatosRepetidosCSharp
{
	public partial class MainForm : Form
	{
		private List<ConsultoraPedido> ListaConsultoraPedido;
		private List<DatoRepetido> ListaDatosRepetidos;

		public MainForm()
		{
			InitializeComponent();

			// Inicializamos la lista uno.
			ListaConsultoraPedido = new List<ConsultoraPedido>();
			// Creamos 4 pedidos diferentes.
			List<int> nrosPedido = new List<int> { 881038103, 804103840, 800438425, 844504854 };
			// Creamos el valor aleatorio basado en 0.
			var random = new Random(0);

			// Añadimos 1000 registros a la lista.
			for (int i = 0; i < 1000; i++)
			{
				ListaConsultoraPedido.Add(new ConsultoraPedido
				{
					Consultora = i + 1000,
					Pedido = nrosPedido[random.Next(3)], 
					// Escogemos el Pedido aleatorio hasta máximo 3 (el último de la colección).
				});
			}

			// Asignamos la variable al BindingSource de ConsultoraPedido.
			consultoraPedidoBindingSource.DataSource = ListaConsultoraPedido;

			// Mostramos el Total de elementos.
			txtTotal1.Text = ListaConsultoraPedido.Count.ToString();

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// Nos aseguramos que la primera lista contenga información.
			if (ListaConsultoraPedido == null) return;

			// Crearemos un query Linq para examinar los datos repetidos.
			var query = ListaConsultoraPedido.GroupBy(pedido => pedido.Pedido)
											.Select(group => new DatoRepetido
											{
												Pedido = group.Key,
												Cantidad = group.Count()
											})
											.OrderBy(x => x.Pedido);
			
			// El resultado del query lo añadimos a la segunda lista.
			ListaDatosRepetidos = query.ToList();
			// Ahora los asignamos al control BindingSource.
			datoRepetidoBindingSource.DataSource = ListaDatosRepetidos;
			// Mostramos el Total de la segunda lista.
			txtTotal2.Text = ListaDatosRepetidos.Count.ToString();

		}
	}
}
