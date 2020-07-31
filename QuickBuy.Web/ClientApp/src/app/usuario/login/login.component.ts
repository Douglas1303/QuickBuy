import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { Router, ActivatedRoute } from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html", //qual é meu html
  styleUrls: ["./login.component.css"] //qual é a folha de estilo
})
export class LoginComponent implements OnInit {
  public usuario;
  public returnUrl: string; 
 

  constructor(private router: Router, private activateRouter: ActivatedRoute) {
    
     
  }
    ngOnInit(): void {
      this.returnUrl = this.activateRouter.snapshot.queryParams['returnUrl'];
      this.usuario = new Usuario();
    }

  entrar() {
    if (this.usuario.email == "douglas@teste.com" && this.usuario.senha == "123") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]); 
    }
  }
}
