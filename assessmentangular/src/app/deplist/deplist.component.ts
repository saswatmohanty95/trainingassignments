import { Component, OnInit } from '@angular/core';
import { DepartmentService } from '../department.service';
import { Department } from '../department';
import {Router} from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-deplist',
  templateUrl: './deplist.component.html',
  styleUrls: ['./deplist.component.css']
})
export class DeplistComponent implements OnInit {
  deptmnt: Department;
  dplist: Department[];
  updatediv=false;
  indexposition:number;
  constructor(private ds:DepartmentService,private route :Router) { 
    this.dplist=this.ds.getDeptlist();
  }

  ngOnInit() {
  }
  edit(index:number)
  {   
    console.log("Index "+index);
     this.updatediv=true; 
     this.deptmnt=this.dplist[index];
    this.ds.update(this.deptmnt,this.indexposition);  
   }
  deleteDept(index:number)
  {
    this.ds.delete(index);
   }


}
