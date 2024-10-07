using System.Collections.Generic;
using System.Linq;

public class DataBaseSimulation
{
    private List<Articulo> Articulos;

    public DataBaseSimulation()
    {
        Articulos = new List<Articulo>
        {
            new Articulo { Id = 1, Nombre = "CONE VISI-FLOW STOMA", Descripcion = "Cono para irrigación Visi-Flow Stoma", Precio = 150, Descuento = (decimal)0, RutaImagen = "https://marketingworld.convatec.com/Api/PresentationMediaResizer?applicationToken=97b2194ccf7ca14bbacb2671e4cefd84d0322d70909e014eac585265d749b2cb&mediaFileId=a40660b4-2562-45a4-b43d-c2217804003c&format=webp&width=876&height=876" },
            new Articulo { Id = 2, Nombre = "TUBE SURGILUBE 4.25-OZ.", Descripcion = "Tubo de Surgilube de 4.25 onzas", Precio = 80, Descuento = (decimal)0, RutaImagen = "https://m.media-amazon.com/images/I/61Ip0-HA2kL._AC_UF1000,1000_QL80_.jpg" },
            new Articulo { Id = 3, Nombre = "LUBRIFIANT 63655", Descripcion = "Lubricante médico 63655", Precio = 90, Descuento = (decimal)0, RutaImagen = "https://sumeba.com.mx/wp-content/uploads/2023/11/LUBRI6.jpg" },
            new Articulo { Id = 4, Nombre = "BRUSH VISI-FLOW IRRIG", Descripcion = "Cepillo para irrigación Visi-Flow", Precio = 120, Descuento = (decimal)0, RutaImagen = "https://m.media-amazon.com/images/I/71j+5QJjzxL.jpg" },
            new Articulo { Id = 5, Nombre = "BROSSE 63239", Descripcion = "Cepillo Brosse 63239", Precio = 70, Descuento = (decimal)0, RutaImagen = "https://curaprox.mx/7069-large_default/cepillo-de-limpieza-bdc-menta.jpg" },
            new Articulo { Id = 6, Nombre = "CEPILLO", Descripcion = "Cepillo genérico para uso médico", Precio = 60, Descuento = (decimal)0, RutaImagen = "https://http2.mlstatic.com/D_NQ_NP_858523-MLU71234977270_082023-O.webp" },
            new Articulo { Id = 7,  Nombre = "CASE CARRY VISI-FLOW IRRIG", Descripcion = "Estuche de transporte para Visi-Flow", Precio = 200, Descuento = (decimal)0, RutaImagen = "https://m.media-amazon.com/images/I/61OrsUAMHuL._AC_UY580_.jpg" },
            new Articulo { Id = 8,  Nombre = "IRRIGATOR TROUSSE 63849", Descripcion = "Kit de irrigación Trousse 63849", Precio = 180, Descuento = (decimal)0, RutaImagen = "https://dolphinmedical.com/dolphinmedical.com/wp-content/uploads/2019/05/kit-trompeta_1.jpg" },
            new Articulo { Id = 9,  Nombre = "DISCONNECT MALE VISI-FLOW", Descripcion = "Desconector masculino para Visi-Flow", Precio = 130, Descuento = (decimal)0, RutaImagen = "https://ch-delivery.lincolnelectric.com/api/public/content/21430874648849c4bdffabcbd95004fd?v=05771ad5&t=600x429" },
            new Articulo { Id = 10,  Nombre = "FACEPLATE IRRIG ADAPT 45MM", Descripcion = "Adaptador de placa de irrigación 45MM", Precio = 250, Descuento = (decimal)0, RutaImagen = "https://http2.mlstatic.com/D_NQ_NP_882684-MLM54059624550_022023-O.webp" },
            new Articulo { Id = 11,  Nombre = "ADAPTADOR CIRCULAR 45 MM", Descripcion = "Adaptador circular de 45MM", Precio = 100, Descuento = (decimal)0, RutaImagen = "https://m.media-amazon.com/images/I/51UdFHs829L._AC_UF894,1000_QL80_.jpg" },
            new Articulo { Id = 12,  Nombre = "FACEPLATE IRRIG ADAPT 70MM", Descripcion = "Adaptador de placa de irrigación 70MM", Precio = 280, Descuento = (decimal)0, RutaImagen = "https://qualitymed.mx/wp-content/uploads/2020/05/E05042.jpg" },
            new Articulo { Id = 13,  Nombre = "CONNECTOR MALE ACCUSEAL TUBE", Descripcion = "Conector masculino para tubo Accuseal", Precio = 150, Descuento = (decimal)0, RutaImagen = "https://dinet.com.mx/wp-content/uploads/2021/10/9570300.png" },
            new Articulo { Id = 14,  Nombre = "S3 STRIP 150X20MM (1X15PK) US", Descripcion = "Tira S3 de 150x20mm (1x15 paquete)", Precio = 110, Descuento = (decimal)0, RutaImagen = "https://www.kolormats.mx/wp-content/uploads/2020/12/70070549194.png" },
            new Articulo { Id = 15,  Nombre = "CABLE-TIE (TY-RAP) VISI-FLOW", Descripcion = "Amarre de cables Ty-Rap para Visi-Flow", Precio = 60, Descuento = (decimal)0, RutaImagen = "https://static.grainger.com/rp/s/is/image/Grainger/4YF30_GC01?$glgmain$" },
            new Articulo { Id = 16,  Nombre = "BASE ROD LOOP 90MM", Descripcion = "Base de varilla de 90mm", Precio = 140, Descuento = (decimal)0, RutaImagen = "https://productosdelaboratorio.com/cdn/shop/products/soporte-base-H_b754b068-3e6b-4d24-a878-560d59dd31d6_580x.jpg?v=1558402232" },
            new Articulo { Id = 17,  Nombre = "SWIVEL ROD LOOP", Descripcion = "Varilla giratoria", Precio = 90, Descuento = (decimal)0, RutaImagen = "https://ihnlver43yzmlyywutd270y.blob.core.windows.net/azureimages/400Wx400H/EF_Drehstange_6_5_blank_shop.jpg" },
        };
    }

    public void AltaArticulo(Articulo articulo)
    {
        Articulos.Add(articulo);
    }

    public List<Articulo> BuscarPorNombreODescripcion(string parametro)
    {
        return Articulos.Where(a => a.Nombre.Contains(parametro) || a.Descripcion.Contains(parametro) || a.Id.ToString().Contains(parametro)).ToList();
    }
    public Articulo BuscarPorNombre(string nombre)
    {
        return Articulos.FirstOrDefault(a => a.Nombre == nombre);
    }
    public List<Articulo> BuscarPorDescripcion(string descripcion)
    {
        return Articulos.Where(a => a.Descripcion.Contains(descripcion)).ToList();
    }

    public List<Articulo> VerTodosLosArticulos()
    {
        return Articulos;
    }
}