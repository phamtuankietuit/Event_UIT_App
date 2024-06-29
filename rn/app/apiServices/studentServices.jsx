import * as request from "../utils/request"
export const getRegisteredEvents = async () => {
    try {
        // false đầu là ko cần xác thực (accessToken)
        // false thứ 2 là ko phải quản lý trang => là sinh viên
        // obj là body mà BE cần
        const res = await request.getMethod("students/me/events", true)
        return res
    } catch (error) {
        return Promise.reject(error)
    }
}

export const getTrainingPointHistory = async () => {
    try {
        // false đầu là ko cần xác thực (accessToken)
        // false thứ 2 là ko phải quản lý trang => là sinh viên
        // obj là body mà BE cần
        const res = await request.getMethod("students/me/training-point-history", true)
        return res
    } catch (error) {
        return Promise.reject(error)
    }
}

export const getMe = async () => {
  try {
    const res = await request.getMethod("users/students/me", true)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}
