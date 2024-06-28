import * as request from "../utils/request"

export const getPages = async () => {
    try {
        // false đầu là ko cần xác thực (accessToken)
        // false thứ 2 là ko phải quản lý trang => là sinh viên
        // obj là body mà BE cần
        const res = await request.getMethod("university-units", false)
        return res
    } catch (error) {
        return Promise.reject(error)
    }
}

export const getPage = async (id) => {
    try {
        // false đầu là ko cần xác thực (accessToken)
        // false thứ 2 là ko phải quản lý trang => là sinh viên
        // obj là body mà BE cần
        const res = await request.getMethod("university-units/" + id, false)
        return res
    } catch (error) {
        return Promise.reject(error)
    }
}