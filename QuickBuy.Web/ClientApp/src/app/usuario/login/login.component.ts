import { Component } from "@angular/core";
import { Usuario } from "../../model/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html", //qual é meu html
  styleUrls: ["./login.component.css"] //qual é a folha de estilo
})
export class LoginComponent {
  public usuario;

  constructor() {
    this.usuario = new Usuario(); 
  }
}
