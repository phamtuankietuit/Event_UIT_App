import {
  Text,
  View,
  TouchableOpacity,
  Image,
  ActivityIndicator,
  Pressable,
  Alert,
} from "react-native"
import React, { memo, useEffect, useState } from "react"
import { SliderBox } from "react-native-image-slider-box"
import { Entypo } from "@expo/vector-icons"
import { Link } from "expo-router"
import dayjs from "dayjs"

const EventItem = memo(({ item }) => {
  const [slides, setSlides] = useState([])
  const [status, setStatus] = useState(null)
  const [buttonLoading, setButtonLoading] = useState(false)

  const confirmRegister = () =>
    Alert.alert("Xác nhận đăng ký", "Bạn có chắc chắn đăng ký sự kiện này?", [
      {
        text: "Hủy",
        onPress: () => console.log("Cancel Pressed"),
        style: "cancel",
      },
      { text: "OK", onPress: () => console.log("OK Pressed") },
    ])

  useEffect(() => {
    setSlides(item.images.map((image) => image.imageUrl))

    if (dayjs() >= dayjs(item.startDate) && dayjs() <= dayjs(item.endDate)) {
      setStatus(1)
    } else if (dayjs() < dayjs(item.startDate)) {
      setStatus(0)
    } else {
      setStatus(2)
    }
  }, [])

  return (
    <View
      className='mb-2 max-h-fit w-full rounded border-[1px] 
        border-gray-100 bg-white p-3 shadow-sm shadow-gray-600'
    >
      <Link href={{ pathname: "(page)/page-detail/[id]", params: { id: 1 } }}>
        <View className='flex-row items-center justify-between'>
          <View className='flex-row items-center justify-center'>
            <View className='h-10 w-10 rounded-full border-[1px] border-gray-400'>
              <Image
                className='h-full w-full rounded-full'
                source={{
                  uri: item.universityUnit.avatarUrl,
                }}
              ></Image>
            </View>

            <View className='ml-2 w-[180px]'>
              <Text
                numberOfLines={1}
                ellipsizeMode='tail'
                lineBreakMode='tail'
                className='text-base font-semibold'
              >
                {item.universityUnit.name}
              </Text>
              <Text className='text-xs'>
                {dayjs(item.publishedDate).format("HH:mm - DD/MM/YYYY")}
              </Text>
            </View>
          </View>

          {status !== null && (
            <View className=''>
              <Text
                className={`
              ${status === 0 && "text-orange-500"}
              ${status === 1 && "text-green-500"}
              ${status === 2 && "text-red-500"} 
              text-sm font-medium `}
              >
                {status === 0 && "Chưa bắt đầu"}
                {status === 1 && "Đang diễn ra"}
                {status === 2 && "Kết thúc"}
              </Text>
              <Text className='text-xs'>
                {item.totalRegistration}/{item.maxAttendees}
              </Text>
            </View>
          )}
        </View>
      </Link>

      <View className='mt-2'>
        <Text
          className='text-base font-medium'
          numberOfLines={2}
          ellipsizeMode='tail'
        >
          {item.title}
        </Text>
        <Text numberOfLines={5} ellipsizeMode='tail'>
          {item.description}
        </Text>
        <Link
          href={{
            pathname: "/(page)/post-detail/[id]",
            params: { id: item.id },
          }}
        >
          <Text className='text-blue-500'>Xem thêm</Text>
        </Link>
      </View>

      <View className='mt-2 max-h-[200px] items-center justify-center'>
        <SliderBox
          images={slides}
          dotColor='#FFFFFF'
          inactiveDotColor='#F5F5F5'
          ImageComponentStyle={{ borderRadius: 5, width: "80%" }}
          imageLoadingColor='#3A57E8'
        />
      </View>

      <View className='my-3 h-[0.5px] w-full bg-gray-300'></View>

      <View className='flex-row justify-between'>
        <TouchableOpacity className='rounded bg-blue-500 px-5 py-2'>
          <Entypo name='link' size={20} color='white' />
        </TouchableOpacity>

        {/* bg-slate-400 */}

        {item.isThisStudentRegistered ? (
          <View className='rounded bg-slate-500 px-5 py-2'>
            <Text className='font-medium text-white'>Đã đăng ký</Text>
          </View>
        ) : (
          <TouchableOpacity
            className='rounded bg-blue-500 px-5 py-2'
            onPress={confirmRegister}
            disabled={buttonLoading}
          >
            {buttonLoading ? (
              <ActivityIndicator size='small' color='#ffffff' />
            ) : (
              <Text className='font-medium text-white'>Đăng ký</Text>
            )}
          </TouchableOpacity>
        )}
      </View>
    </View>
  )
})

export default EventItem
