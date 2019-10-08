import { HttpClient } from '@angular/common/http';
import { Department } from './department';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  private deptlist:Department[]=[
    {deptid:1,name:'Engineering',groupName:'Research and Development', modifiedDate: '2019-10-09'},
    {deptid:2,name:'Tool Design',groupName:'Research and Development', modifiedDate:'2019-10-09'},
    {deptid:3,name:'Sales',groupName:'Sales', modifiedDate:'2019-10-09'},
  ];

  constructor() { }
  getDeptlist(){
    return this.deptlist;
    }

    save(dep:Department)
    {
      this.deptlist.push(dep);
    }

    update(dep:Department,index:number)
  {
     this.deptlist[index]=dep;
      }
  delete(index :number)
  {
    this.deptlist.splice(index,1);
  }
}
