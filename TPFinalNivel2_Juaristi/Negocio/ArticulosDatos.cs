﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticulosDatos
    {
        // Método que retorna una lista de objetos Articulo:
        public List<Articulo> listar()
        {
            Acceso_DB datos = new Acceso_DB();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, C.Descripcion Categoria, M.Descripcion Marca, IdCategoria, IdMarca, ImagenUrl, Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.Id");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImg = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Agregar(Articulo articulo_a_agregar)
        {
            Acceso_DB datos = new Acceso_DB();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@codigo, @nombre, @descripcion, @id_marca, @id_categoria, @imagen, @precio");
                
                datos.setearParametros("@codigo", articulo_a_agregar.Codigo);
                datos.setearParametros("@nombre", articulo_a_agregar.Nombre);
                datos.setearParametros("@descripcion", articulo_a_agregar.Descripcion);
                datos.setearParametros("@id_marca", articulo_a_agregar.Marca.Id);
                datos.setearParametros("@id_categoria", articulo_a_agregar.Categoria.Id);
                datos.setearParametros("@imagen", articulo_a_agregar.UrlImg);
                datos.setearParametros("@precio", articulo_a_agregar.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}