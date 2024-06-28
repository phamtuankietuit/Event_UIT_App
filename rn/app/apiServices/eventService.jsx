import * as request from "../utils/request"

export const createEvent = async (obj) => {
  try {
    // false đầu là ko cần xác thực (accessToken)
    // false thứ 2 là ko phải quản lý trang => là sinh viên
    // obj là body mà BE cần
    const res = await request.postMethod("auth/events", false, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}