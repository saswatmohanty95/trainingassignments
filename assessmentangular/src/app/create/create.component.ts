import { Component, OnInit } from '@angular/core';
import { DepartmentService } from '../department.service';
import { Department } from '../department';
import {Router} from '@angular/router';
import {NgForm} from '@angular/forms';
@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {
  deptmnt= new Department();
  constructor(private ds: DepartmentService, private route: Router) { }

  ngOnInit() {
  }
  saveDepartment():void{
    this.ds.save(this.deptmnt);
    console.log(this.deptmnt);
  }
}
