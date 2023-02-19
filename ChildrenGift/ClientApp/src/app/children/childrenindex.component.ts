import { Component, NgModule, OnInit } from '@angular/core';
import { Children } from '../models/children';
import { ChildrenService } from '../services/children.service';
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';


@NgModule({
    imports: [CommonModule]
})
@Component({
    selector: 'app-counter-component',
    templateUrl: './childrenindex.component.html'
})

export class ChildrenIndexComponent implements OnInit {
    public currentCount = 0;
    public childrenList$: Observable<any[]>;

    constructor(private _ChildrenService: ChildrenService) {
    }

    ngOnInit() : void {
        this.getChildren();
    }

    getChildren() {
        this._ChildrenService.getChildren().subscribe(data => {
            //console.log(data);
            this.childrenList$ = data;
            //console.log(this.childrenList);
        });
        error => console.error(error);
        //console.log(this.childrenList);
    }

    public incrementCounter() {
        this.currentCount++;
    }
}
