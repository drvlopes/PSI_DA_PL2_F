using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestGuest
{
    public partial class Categoria
    {
        public override string ToString()
        {
            return Nome;
        }
    }

    public partial class Cliente
    {
        public override string ToString()
        {
            return $"{Nome}: {NumContribuinte}";
        }

        public string Total()// devolve o total gasto pelo cliente em todos os pedidos que estão concluidos
        {
            var pedidos = Pedidos.ToList().Where(p => p.Estado.Id == 4);
            double total = 0;
            foreach (var pedido in pedidos)
            {
                var pagamentos = pedido.Pagamentos.ToList();
                foreach (var pagamento in pagamentos)
                {
                    total += pagamento.Valor;
                }
            }

            return total.ToString();
        }

    }

    public partial class Estado
    {
        public override string ToString()
        {
            return Status;
        }
    }

    public partial class ItemMenu
    {
        public override string ToString()
        {
            return $"{Nome} {Preco} €";

        }
    }

    public partial class MetodoPagamento
    {
        public override string ToString()
        {
            return MetPagamento;
        }
    }

    public partial class Pedido
    {
        public override string ToString()
        {
            return $"({Id}) {Cliente.Nome}";
        }

        public string TotalPedido()
        {
            double total = 0;
            foreach (var item in this.Pagamentos)
            {
                total  +=  item.Valor;
            }
            return total.ToString();
        }

    }

    public partial class Restaurante
    {
        public override string ToString()
        {
            return $"{Nome} ({Trabalhadores.Count})";
        }
    }

    public partial class Trabalhador
    {
        public override string ToString()
        {
            return $"{Nome}: {Posicao}";
        }
    }
}
