import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map, distinctUntilChanged } from 'rxjs/operators';

@Injectable()
export abstract class IStorageService {
  abstract SetState(key: string, value: any): void;
  abstract GetState<T = any>(key: string): Observable<T>;
  abstract GetItem(key: string): any;
  abstract SetItem(key: string, value: any): void;
  abstract RemoveItem(key: string);
  abstract Clear(): void;
}

interface StorageState {
  [key: string]: any;
}

@Injectable()
export class StorageService implements IStorageService {

  private state: StorageState = {};
  private store = new BehaviorSubject<StorageState>(this.state);

  private state$ = this.store.asObservable();

  public SetState(key: string, value: any): void {
    Object.keys(this.state);
    if (this.state.hasOwnProperty(key)) {
      this.state[key] = value;
    } else {
      Object.defineProperty(this.state, key, { value: value, writable: true });
    }

    this.store.next(this.state);
    localStorage[key] = JSON.stringify(value);
  }

  public GetState<T = any>(key: string): Observable<T> {
    return this.state$.pipe(
      map(state => {
        // just to ensure immutability
        return state[key] instanceof Object ?
          { ...state[key] }
          : (state[key] instanceof Array ?
            [...state[key]] as unknown as T
            : state[key]);
      }),
      distinctUntilChanged()
    );
  }

  constructor() {
    for (let index = 0; index < localStorage?.length; index++) {
      const key = localStorage.key(index)
      try {
        this.state[key] = JSON.parse(localStorage[key]);
      } catch (error) {
        this.state[key] = localStorage[key];
      }
    }
  }

  public GetItem(key: string) {
    return localStorage[key];
  }

  public SetItem(key: string, value: any): void {
    localStorage.setItem(key, value);
  }

  public RemoveItem(key: string) {
    localStorage.removeItem(key);
  }

  public Clear(): void {
    localStorage.clear();
  }
}



