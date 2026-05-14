namespace TrabajoPractico2.Models;

public class Receta
{
    public string nombre {get;set;}
    public DateTime fechaNacimiento {get;set;}
    public string tipoComida {get;set;}
    public int presupuesto {get;set;}
    public int cantPersonas {get;set;}

    public int CalcularEdad(){
        int edad = DateTime.Today.Year - fechaNacimiento.Year;
        if(DateTime.Today.Month > fechaNacimiento.Month && DateTime.Today.Day > fechaNacimiento.Day){
            edad +=1;
        }
        return edad;
    }
    public string DeterminarPlato(Receta r){
        if(r.tipoComida == "caliente"){
            if(r.presupuesto<3000){
                return "fideos con manteca";
            }
            else if (r.presupuesto>=3000 && r.presupuesto<=7000){
                return "arroz con verduras salteadas";
            }
            else{
                return "pollo al horno con guarnicion";
            }
        }
        else{
            if (r.presupuesto<3000){
                return "ensalada simple";
            }
            else if (r.presupuesto>=3000 && r.presupuesto<=7000){
                return "ensalada completa con proteina";
            }
            else{
                return "tabla de fiambres y quesos";
            }
        }
    }
    public int CalcularTiempo(Receta r){

        if(r.tipoComida=="caliente" && r.cantPersonas>=1 && r.cantPersonas<=3){
            return 20;
        }

        else if (r.tipoComida == "caliente" && r.cantPersonas >= 4 && r.cantPersonas <= 7){
            return 40;
        }

        else if (r.tipoComida == "caliente" && r.cantPersonas >= 8){
            return 80;
        }

        else if (r.tipoComida == "fria" && r.cantPersonas>=1 && r.cantPersonas <=3){
            return 10;
        }

        else if(r.tipoComida== "fria" && r.cantPersonas >=4 && r.cantPersonas <=7){
            return 20;
        }

        else if(r.tipoComida == "fria" && r.cantPersonas >= 8){
            return 40;
        }
        return 0;
    }

    public string DeterminarDificultad(Receta r){
        if(r.presupuesto < 3000){
            if (r.cantPersonas>=1 && r.cantPersonas <=3){
                return "principiante";
            }
            else if (r.cantPersonas >=4 && r.cantPersonas <=7){
                return "intermedio";
            }
        }
        if(r.presupuesto >=3000 && r.presupuesto <=7000){
            if(r.cantPersonas>=1 && r.cantPersonas <=3){
                return "intermedio";
            }
            else{
                return "intermedio";
            }
        }
        else{
            if(r.cantPersonas>=1 && r.cantPersonas<=7){
                return "intermedio";
            }
            else{
                return "avanzado";
            }
        }
    }
    public string GenerarSaludo(){
        if(DateTime.Now.Hour <= 15 && DateTime.Now.Hour >= 7){
            return "Buenos días";
        }
        else if (DateTime.Now.Hour > 15 && DateTime.Now.Hour <= 20){
            return "Buenas tardes";
        }
        else{
            return "Buenas noches";
        }
    }
}