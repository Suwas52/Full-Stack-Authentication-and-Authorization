import { PATH_DASHBOARD, PATH_PUBLIC } from "../routes/paths";

export const HOST_API_KEY = "https://localhost:723/Api";
export const REGISTER_URL = "/Auth/register";
export const Login_URL = "/Auth/login";
export const ME_URL = "/Auth/me";
export const USERS_LIST_URL = "/Auth/update-role";
export const UPDATE_ROLE_URL = "/Auth/update-role";
export const USERNAMES_LIST_URL = "/Auth/usernames";
export const ALL_MESSAGES_URL = "/Messages";
export const MY_MESSAGE_URL = "/Messages/Create";
export const LOGS_URL = "/Logs";
export const MY_LOGS_URL = "/Logs/Mine";

//Auth Routes
export const PATH_AFTER_REGISTER = PATH_PUBLIC.login;
export const PATH_AFTER_LOGIN = PATH_DASHBOARD.dashboard;
export const PATH_AFTER_LOGOUT = PATH_PUBLIC.home;
