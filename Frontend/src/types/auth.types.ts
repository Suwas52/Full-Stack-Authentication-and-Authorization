export interface IRegisterDto {
  firstName: string;
  lastName: string;
  userName: string;
  email: string;
  password: string;
  address: string;
}

export interface ILoginDto {
  userName: string;
  password: string;
}

export interface IUpdateRoleDto {
  userName: string;
  newRole: string;
}

export interface IAuthUser {
  id: string;
  firstName: string;
  lastName: string;
  userName: string;
  email: string;
  createdAt: string;
  roles: string[];
}

export interface ILoginResponseDto {
  newToken: string;
  userInfo: string;
}

export interface IAuthContextState {}
