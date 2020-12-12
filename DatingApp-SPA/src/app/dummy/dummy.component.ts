import { HttpClient } from '@angular/common/http';
import { Component, OnInit,} from '@angular/core';

@Component({
  selector: 'app-dummy',
  templateUrl: './dummy.component.html',
  styleUrls: ['./dummy.component.scss']
})
export class DummyComponent implements OnInit {

  dummies: any;

  constructor(private http:HttpClient) { }

  ngOnInit() {
    this.getValues();
  }

  getValues(){
    this.http.get("http://localhost:5000/api/Dummy").subscribe(response =>{
      this.dummies = response;
    }, error => {
      console.log(error);
    });
  }
}